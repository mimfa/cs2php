﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Lang.Php;

namespace Lang.Php.Test.Code
{
    [IgnoreNamespace]
    [ScriptName("MyCodePhp")]
    public class MyCode
    {
        public static void BasicMath1()
        {
            var a = 1;
            var b = 2;
            var d = (a + b) / Math.PI;
        }

        public static void PregTest()
        {
            Dictionary<object, PregMatchWithOffset> matchWithOffsets;
            Dictionary<object, string> matches;
            var a = Preg.Match("/hello/i", "a Hello x", out matches, 2);
            var b = Preg.Match("/hello/i", "a Hello x");
            var c = Preg.MatchWithOffset("/hello/i", "ó Hello world", out matchWithOffsets);
            PhpDummy.echo("We have " + matchWithOffsets[0].Value + " at " + matchWithOffsets[0].Offset);

        }

        public static void CostantsAndVariables()
        {
            object a = null;
            int b = 0x12;
            double c = 1.2;
            double pi = Math.PI;
            string h = "Some text backslash\\ quote\" single' dollar$";
            string jacob = @"\anything";

            var x = "test {h}";
        }

        public static void Collections()
        {
            // List
            List<string> list = new List<string>();
            foreach (var i in list)
                PhpDummy.echo(i);
            var count = list.Count;

            // Dictionary
            Dictionary<string, string> dict = new Dictionary<string, string>();
            foreach (var i in dict)
                PhpDummy.echo(i.Key + " " + i.Value);
            foreach (var i in dict.Values)
                PhpDummy.echo(i);
            foreach (var i in dict.Keys)
                PhpDummy.echo(i);
            // var values = dict.Values;
            // var keys = dict.Keys;
            count = dict.Count;

            // Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("X");
            stack.Push("Y");
            var s1 = stack.Peek();
            var s2 = stack.Pop();
            count = stack.Count;
        }

        public static void StringConcats()
        {
            int x = 3;
            var a = "a" + "b";
            var b = "a" + (x / 2 < 10 ? "b" : "c");
            var c = "a" + (x / 2 < 10 ? "b" : "c") + "d";
        }

        public static void SimpleEquations()
        {

        }

    }
}
