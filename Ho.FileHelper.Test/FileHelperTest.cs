using System;
using System.Threading;
using Xunit;
using static Ho.FileHelper.Lib.FileHelper;

namespace Ho.FileHelper.Test
{
    public class FileHelperTest
    {
        [Fact]
        public void SolutionFolder_ShouldReturn_FullPathToSolutionFolder()
        {
            string expectedPathToSolution = @"C:\Users\herbert.ho\Documents\src\_CSharp\Useful Classes\Ho.FileHelper.Lib";
            Assert.Equal(expectedPathToSolution, SolutionFolder());
        }

        [Fact]
        public void AppendDateTime_ShouldReturn_DifferentStrings()
        {
            string fileName = "myFile";
            string firstResult = AppendDateTime(fileName);
            Thread.Sleep(1000);
            string secondResult = AppendDateTime(fileName);
            Assert.NotEqual(firstResult, secondResult);
        }
    }
}
