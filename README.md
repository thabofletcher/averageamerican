﻿Average American Consumer
================

C# client for anything JSON

## Usage

	var model = new Consumer<T>().Consume(url);
	var dynamicModel = new Dynamo().Consume(url);
	
## [Package Manager Console](http://docs.nuget.org/docs/start-here/using-the-package-manager-console) Installation

	PM> Install-Package ConsumerTemplate
	
## Details/More Info

	using AverageAmerican;
	
	var basicAuthConsumer = new Dynamo(username, password);
	
	// only do this for a proof of concept, MITM attacks against your application aren't fun
	basicAuthConsumer.IgnoreCertErrors(); 

##License

The MIT License (MIT)

Copyright (c) 2013 Thabo Fletcher

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
