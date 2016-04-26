﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NMF.Models;
using Orleans;
using Orleans.Streams;
using Orleans.Streams.Linq.Aggregates;

namespace NMF.Expressions.Linq.Orleans.Model
{
    public abstract class ModelProcessingAggregateGrain<TSource, TResult, TNode> : StreamProcessorAggregate<TSource, TResult, TNode>, IModelProcessingAggregateGrain<TSource, TResult, NMF.Models.Model>
         where TNode : IModelProcessingNodeGrain<TSource, TResult, NMF.Models.Model>
    {
        protected IModelContainerGrain<Models.Model> ModelContainer;

        public Task SetModelContainer(IModelContainerGrain<NMF.Models.Model> modelContainer)
        {
            ModelContainer = modelContainer;
            return TaskDone.Done;
        }

        public async Task LoadModel(Func<NMF.Models.Model> modelLoadingFunc)
        {
            await Task.WhenAll(ProcessorNodes.Select(p => p.LoadModel(modelLoadingFunc)));
        }

        public Task<string> ModelToString(Func<Models.Model, IModelElement> elementSelectorFunc)
        {
            throw new NotImplementedException();
        }
    }
}