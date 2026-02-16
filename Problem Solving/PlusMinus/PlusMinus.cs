{\rtf1\ansi\ansicpg1252\cocoartf2867
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fmodern\fcharset0 Courier;}
{\colortbl;\red255\green255\blue255;\red0\green0\blue255;\red255\green255\blue254;\red0\green0\blue0;
\red22\green107\blue41;\red144\green1\blue18;}
{\*\expandedcolortbl;;\cssrgb\c0\c0\c100000;\cssrgb\c100000\c100000\c99608;\cssrgb\c0\c0\c0;
\cssrgb\c7451\c48627\c21176;\cssrgb\c63922\c8235\c8235;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\partightenfactor0

\f0\fs30 \cf2 \cb3 \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec2 using\cf0 \strokec4  System.CodeDom.Compiler;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Collections.Generic;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Collections;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.ComponentModel;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Diagnostics.CodeAnalysis;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Globalization;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.IO;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Linq;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Reflection;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Runtime.Serialization;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Text.RegularExpressions;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System.Text;\cb1 \
\cf2 \cb3 \strokec2 using\cf0 \strokec4  System;\cb1 \
\
\cf2 \cb3 \strokec2 class\cf0 \strokec4  Result\cb1 \
\pard\pardeftab720\partightenfactor0
\cf0 \cb3 \{\cb1 \
\
\cb3     \cf5 \strokec5 /*\cf0 \cb1 \strokec4 \
\pard\pardeftab720\partightenfactor0
\cf5 \cb3 \strokec5      * Complete the 'plusMinus' function below.\cf0 \cb1 \strokec4 \
\cf5 \cb3 \strokec5      *\cf0 \cb1 \strokec4 \
\cf5 \cb3 \strokec5      * The function accepts INTEGER_ARRAY arr as parameter.\cf0 \cb1 \strokec4 \
\cf5 \cb3 \strokec5      */\cf0 \cb1 \strokec4 \
\
\pard\pardeftab720\partightenfactor0
\cf0 \cb3     \cf2 \strokec2 public\cf0 \strokec4  \cf2 \strokec2 static\cf0 \strokec4  \cf2 \strokec2 void\cf0 \strokec4  plusMinus(List<\cf2 \strokec2 int\cf0 \strokec4 > arr)\cb1 \
\cb3     \{\cb1 \
\cb3         \cf2 \strokec2 int\cf0 \strokec4  count = arr.Count;\cb1 \
\cb3         \cf2 \strokec2 decimal\cf0 \strokec4  positives = \cf5 \strokec5 0\cf0 \strokec4 ;\cb1 \
\cb3         \cf2 \strokec2 decimal\cf0 \strokec4  negatives = \cf5 \strokec5 0\cf0 \strokec4 ;\cb1 \
\cb3         \cf2 \strokec2 decimal\cf0 \strokec4  zeros = \cf5 \strokec5 0\cf0 \strokec4 ;\cb1 \
\cb3         \cf2 \strokec2 for\cf0 \strokec4  (\cf2 \strokec2 int\cf0 \strokec4  i = \cf5 \strokec5 0\cf0 \strokec4 ; i < count; i++)\cb1 \
\cb3         \{\cb1 \
\cb3             \cf2 \strokec2 if\cf0 \strokec4  (arr[i] < \cf5 \strokec5 0\cf0 \strokec4 )\cb1 \
\cb3             \{\cb1 \
\cb3                 negatives++;\cb1 \
\cb3             \}\cb1 \
\cb3             \cf2 \strokec2 else\cf0 \strokec4  \cf2 \strokec2 if\cf0 \strokec4  (arr[i] > \cf5 \strokec5 0\cf0 \strokec4 )\cb1 \
\cb3             \{\cb1 \
\cb3                 positives++;\cb1 \
\cb3             \}\cb1 \
\cb3             \cf2 \strokec2 else\cf0 \cb1 \strokec4 \
\cb3             \{\cb1 \
\cb3                 zeros++;\cb1 \
\cb3             \}\cb1 \
\cb3         \}\cb1 \
\cb3         Console.WriteLine((positives / count).ToString(\cf6 \strokec6 "N6"\cf0 \strokec4 ));\cb1 \
\cb3         Console.WriteLine((negatives / count).ToString(\cf6 \strokec6 "N6"\cf0 \strokec4 ));\cb1 \
\cb3         Console.WriteLine((zeros / count).ToString(\cf6 \strokec6 "N6"\cf0 \strokec4 ));\cb1 \
\cb3     \}\cb1 \
\
\cb3 \}\cb1 \
\
\pard\pardeftab720\partightenfactor0
\cf2 \cb3 \strokec2 class\cf0 \strokec4  Solution\cb1 \
\pard\pardeftab720\partightenfactor0
\cf0 \cb3 \{\cb1 \
\cb3     \cf2 \strokec2 public\cf0 \strokec4  \cf2 \strokec2 static\cf0 \strokec4  \cf2 \strokec2 void\cf0 \strokec4  Main(\cf2 \strokec2 string\cf0 \strokec4 [] args)\cb1 \
\cb3     \{\cb1 \
\cb3         \cf2 \strokec2 int\cf0 \strokec4  n = Convert.ToInt32(Console.ReadLine().Trim());\cb1 \
\
\cb3         List<\cf2 \strokec2 int\cf0 \strokec4 > arr = Console.ReadLine().TrimEnd().Split(\cf6 \strokec6 ' '\cf0 \strokec4 ).ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();\cb1 \
\
\cb3         Result.plusMinus(arr);\cb1 \
\cb3     \}\cb1 \
\cb3 \}\cb1 \
\
}