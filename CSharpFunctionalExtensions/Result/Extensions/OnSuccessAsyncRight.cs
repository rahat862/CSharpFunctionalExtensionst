using System;
using System.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        [Obsolete("Use Map() instead.")]
        public static Task<Result<K>> OnSuccess<T, K>(this Result<T> result, Func<T, Task<K>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<K, E>> OnSuccess<T, K, E>(this Result<T, E> result, Func<T, Task<K>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<T>> OnSuccess<T>(this Result result, Func<Task<T>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<K>> OnSuccess<T, K>(this Result<T> result, Func<T, Task<Result<K>>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<K, E>> OnSuccess<T, K, E>(this Result<T, E> result, Func<T, Task<Result<K, E>>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<T>> OnSuccess<T>(this Result result, Func<Task<Result<T>>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<K>> OnSuccess<T, K>(this Result<T> result, Func<Task<Result<K>>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result<K, E>> OnSuccess<T, K, E>(this Result<T, E> result, Func<Task<Result<K, E>>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result> OnSuccess<T>(this Result<T> result, Func<T, Task<Result>> func)
            => Map(result, func);

        [Obsolete("Use Map() instead.")]
        public static Task<Result> OnSuccess(this Result result, Func<Task<Result>> func)
            => Map(result, func);

        [Obsolete("Use Tap() instead.")]
        public static Task<Result<T>> OnSuccess<T>(this Result<T> result, Func<T, Task> action)
            => Tap(result, action);

        [Obsolete("Use Tap() instead.")]
        public static Task<Result<T, E>> OnSuccess<T, E>(this Result<T, E> result, Func<T, Task> action)
            => Tap(result, action);

        [Obsolete("Use Tap() instead.")]
        public static Task<Result> OnSuccess(this Result result, Func<Task> action)
            => Tap(result, action);
    }
}
