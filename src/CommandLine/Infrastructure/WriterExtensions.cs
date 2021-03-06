﻿using System;
using System.Collections.Generic;
using System.IO;

namespace CommandLine.Infrastructure
{
    public static class WriterExtensions
    {
        public static void WriteList<T>(this TextWriter writer, string title, IEnumerable<T> items, Action<T> write)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------");
            foreach (var item in items)
            {
                write(item);
            }
        }

        public static void WriteList(this TextWriter writer, string title, IEnumerable<string> items)
        {
            writer.WriteList(title, items, writer.WriteLine);
        }
    }
}