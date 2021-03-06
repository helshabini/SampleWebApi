﻿using System;
using Xunit;
using SampleWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Tests
{
    public class ReverseWordsTest
    {
        [Fact]
        public void CanHandleNull()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal(string.Empty, sut.Get(null));
        }

        [Fact]
        public void CanHandleEmpty()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal(string.Empty, sut.Get(""));
        }

        [Fact]
        public void CanHandleWhiteSpace()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal(string.Empty, sut.Get(" "));
        }

        [Fact]
        public void CanHandleLeadingSpace()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal(" asdf asdf", sut.Get(" fdsa fdsa"));
        }

        [Fact]
        public void CanHandleTrailingSpace()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal("asdf asdf ", sut.Get("fdsa fdsa "));
        }

        [Fact]
        public void CanHandleDoublepace()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal("asdf  asdf", sut.Get("fdsa  fdsa"));
        }

        [Fact]
        public void CanHandleCultures()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal("شسيب شسيب", sut.Get("بيسش بيسش"));
        }

        [Fact]
        public void CanHandleOneWord()
        {
            ReverseWordsController sut = new ReverseWordsController();
            Assert.Equal("pleh", sut.Get("help"));
        }
    }
}
