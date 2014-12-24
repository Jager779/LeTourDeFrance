using System;
using System.Collections.Generic;

namespace LeTourDeFrance.Backend.Helpers {
    public static class CollectionExtensions {
        public static void Foreach<T>(this IEnumerable<T> source, Action<T> action) {
            foreach (var item in source) {
                action(item);
            }
        }
    }
}