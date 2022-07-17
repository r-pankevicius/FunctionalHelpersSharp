using System;

namespace FunctionalHelpers
{
    /// <summary>
    /// Helpers to combine functions returning bool using logical operators.
    /// </summary>
    /// <remarks>
    /// See discussion https://github.com/dotnet/csharplang/discussions/6284
    /// </remarks>
    public static class Bool
    {
        // NOT "operator": function => !function
        //

        public static Func<bool> Not(Func<bool> fn) =>
                (() => !fn());

        public static Func<T, bool> Not<T>(Func<T, bool> fn) =>
                ((arg) => !fn(arg));

        public static Func<T1, T2, bool> Not<T1, T2>(Func<T1, T2, bool> fn) =>
                ((arg1, arg2) => !fn(arg1, arg2));


        // AND "operator":
        // (function1, function2, .. functionN) => function && function2 && ... functionN
        //

        // function1 && function2
        //
        public static Func<bool> And(Func<bool> fn1, Func<bool> fn2) =>
            () => fn1() && fn2();

        public static Func<T, bool> And<T>(Func<T, bool> fn1, Func<T, bool> fn2) =>
            (arg) => fn1(arg) && fn2(arg);

        public static Func<T1, T2, bool> And<T1, T2>(Func<T1, T2, bool> fn1, Func<T1, T2, bool> fn2) =>
            (arg1, arg2) => fn1(arg1, arg2) && fn2(arg1, arg2);

        public static Func<T1, T2, T3, bool> And<T1, T2, T3>(
            Func<T1, T2, T3, bool> fn1, Func<T1, T2, T3, bool> fn2) =>
                (arg1, arg2, arg3) =>
                    fn1(arg1, arg2, arg3) && fn2(arg1, arg2, arg3);

        // function1 && function2 & function3
        //
        public static Func<bool> And(Func<bool> fn1, Func<bool> fn2, Func<bool> fn3) =>
            () => fn1() && fn2() && fn3();

        public static Func<T, bool> And<T>(Func<T, bool> fn1, Func<T, bool> fn2, Func<T, bool> fn3) =>
            (arg) => fn1(arg) && fn2(arg) && fn3(arg);

        public static Func<T1, T2, bool> And<T1, T2>(Func<T1, T2, bool> fn1, Func<T1, T2, bool> fn2, Func<T1, T2, bool> fn3) =>
            (arg1, arg2) => fn1(arg1, arg2) && fn2(arg1, arg2) && fn3(arg1, arg2);

        public static Func<T1, T2, T3, bool> And<T1, T2, T3>(
            Func<T1, T2, T3, bool> fn1, Func<T1, T2, T3, bool> fn2, Func<T1, T2, T3, bool> fn3) =>
                (arg1, arg2, arg3) =>
                    fn1(arg1, arg2, arg3) && fn2(arg1, arg2, arg3) && fn3(arg1, arg2, arg3);

        // OR "operator":
        // (function1, function2, .. functionN) => function || function2 || ... functionN
        //

        // function1 || function2
        //
        public static Func<bool> Or(Func<bool> fn1, Func<bool> fn2) =>
            () => fn1() || fn2();

        public static Func<T, bool> Or<T>(Func<T, bool> fn1, Func<T, bool> fn2) =>
            (arg) => fn1(arg) || fn2(arg);

        public static Func<T1, T2, bool> Or<T1, T2>(Func<T1, T2, bool> fn1, Func<T1, T2, bool> fn2) =>
            (arg1, arg2) => fn1(arg1, arg2) || fn2(arg1, arg2);

        public static Func<T1, T2, T3, bool> Or<T1, T2, T3>(
            Func<T1, T2, T3, bool> fn1, Func<T1, T2, T3, bool> fn2) =>
                (arg1, arg2, arg3) =>
                    fn1(arg1, arg2, arg3) || fn2(arg1, arg2, arg3);

        // function1 || function2 & function3
        //
        public static Func<bool> Or(Func<bool> fn1, Func<bool> fn2, Func<bool> fn3) =>
            () => fn1() || fn2() || fn3();

        public static Func<T, bool> Or<T>(Func<T, bool> fn1, Func<T, bool> fn2, Func<T, bool> fn3) =>
            (arg) => fn1(arg) || fn2(arg) || fn3(arg);

        public static Func<T1, T2, bool> Or<T1, T2>(Func<T1, T2, bool> fn1, Func<T1, T2, bool> fn2, Func<T1, T2, bool> fn3) =>
            (arg1, arg2) => fn1(arg1, arg2) || fn2(arg1, arg2) || fn3(arg1, arg2);

        public static Func<T1, T2, T3, bool> Or<T1, T2, T3>(
            Func<T1, T2, T3, bool> fn1, Func<T1, T2, T3, bool> fn2, Func<T1, T2, T3, bool> fn3) =>
                (arg1, arg2, arg3) =>
                    fn1(arg1, arg2, arg3) || fn2(arg1, arg2, arg3) || fn3(arg1, arg2, arg3);

        // XOR "operator":
        // function1 ^ function2
        //
        public static Func<bool> Xor(Func<bool> fn1, Func<bool> fn2) =>
            () => fn1() ^ fn2();

        public static Func<T, bool> Xor<T>(Func<T, bool> fn1, Func<T, bool> fn2) =>
            (arg) => fn1(arg) ^ fn2(arg);

        public static Func<T1, T2, bool> Xor<T1, T2>(Func<T1, T2, bool> fn1, Func<T1, T2, bool> fn2) =>
            (arg1, arg2) => fn1(arg1, arg2) ^ fn2(arg1, arg2);

        public static Func<T1, T2, T3, bool> Xor<T1, T2, T3>(
            Func<T1, T2, T3, bool> fn1, Func<T1, T2, T3, bool> fn2) =>
                (arg1, arg2, arg3) =>
                    fn1(arg1, arg2, arg3) ^ fn2(arg1, arg2, arg3);
    }
}
