using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Reflection.Emit;
using Xunit;

namespace ChallengesWithTestsMark8.Tests
{
    public class ChallengesSet04Tests
    {<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 Namespace=ChallengesWithTestsMark8.Tests Type=ChallengesSet04Tests Member=(Name=AddEvenSubtractOdd OverloadingParameters=[(@2 Namespace=System Type=(Name=Int32 ArrayRank=1 ParentType=Int32)),(@2 Namespace=System Type=Int32)]))" Category="CodeSchema_Method" CodeSchemaProperty_IsPublic="True" CommonLabel="AddEvenSubtractOdd" Icon="Microsoft.VisualStudio.Method.Public" IsDragSource="True" Label="AddEvenSubtractOdd(int[], int) : void" SourceLocation="(Assembly=file:///C:/Users/antho/repos/WeeklyChallenges/ChallengesWithTestsMark8.Tests/ChallengesSet04Tests.cs StartLineNumber=15 StartCharacterOffset=20 EndLineNumber=15 EndCharacterOffset=38)" />
    <Node Id="(@1 Namespace=ChallengesWithTestsMark8.Tests Type=ChallengesSet04Tests)" Visibility="Hidden" />
  </Nodes>
  <Links>
    <Link Source="(@1 Namespace=ChallengesWithTestsMark8.Tests Type=ChallengesSet04Tests)" Target="(@1 Namespace=ChallengesWithTestsMark8.Tests Type=ChallengesSet04Tests Member=(Name=AddEvenSubtractOdd OverloadingParameters=[(@2 Namespace=System Type=(Name=Int32 ArrayRank=1 ParentType=Int32)),(@2 Namespace=System Type=Int32)]))" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Member" Label="Member" Icon="CodeSchema_Field" />
    <Category Id="CodeSchema_Method" Label="Method" BasedOn="CodeSchema_Member" Icon="CodeSchema_Method" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="ArrayRank" Label="Array Rank" ValueType="System.String" />
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="Member" Label="Member" ValueType="System.Object" />
    <Name Id="Name" Label="Name" ValueType="System.String" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="OverloadingParameters" Label="Parameter" ValueType="Microsoft.VisualStudio.GraphModel.GraphNodeIdCollection" Formatter="NameValueNoEscape" />
    <Name Id="ParentType" Label="Parent Type" ValueType="System.Object" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(5f6edb8f-2166-447c-baca-784679ac4459.OutputPathUri)" />
    <Alias n="2" Uri="Assembly=file:///C:/Users/antho/.nuget/packages/microsoft.netcore.app/2.1.0/ref/netcoreapp2.1/System.Runtime.dll" />
  </IdentifierAliases>
  <Paths>
    <Path Id="5f6edb8f-2166-447c-baca-784679ac4459.OutputPathUri" Value="file:///C:/Users/antho/repos/WeeklyChallenges/ChallengesWithTestsMark8.Tests/bin/Debug/netcoreapp2.1/ChallengesWithTestsMark8.Tests.dll" />
  </Paths>
</DirectedGraph>
        [Theory]
        [InlineData(new int[] { 2, 6, 8, 3, 1, 3 }, 9)]
        [InlineData(new int[] { 4, 6, 10 }, 20)]
        [InlineData(new int[] { 3, 1, 3 }, -7)]
        [InlineData(new int[] { 2, 3 }, -1)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        // [InlineData(null, 0)] // Assumption: array will not be null
        public void AddEvenSubtractOdd(int[] numbers, int expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            int actual = challenger.AddEvenSubtractOdd(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("a", "aa", "aaa", "aaaa", 1)]
        [InlineData("aa", "a", "aaa", "aaaa", 1)]
        [InlineData("aa", "aaa", "a", "aaaa", 1)]
        [InlineData("aa", "aaa", "aaaa", "a", 1)]
        [InlineData("aa", "aa", "aaa", "aaaa", 2)]
        [InlineData("aaa", "aaa", "aaa", "aaaa", 3)]
        [InlineData("aaaa", "aaaa", "aaaa", "aaaa", 4)]
        [InlineData("", "aa", "aaa", "aaaa", 0)]
        [InlineData("aa", "aa", "", "aaaa", 0)]
        [InlineData("aaaaaaaaa", "a        a", "aaaaaaaa", "aaaaaaaaaaaaaaaaaaaaaaaaa", 8)]
        public void GetLengthOfShortestString(string string1, string string2, string string3, string string4, int expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            int actual = challenger.GetLengthOfShortestString(string1, string2, string3, string4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, 3, 4, 1)]
        [InlineData(2, 2, 3, 4, 2)]
        [InlineData(4, 5, 3, -1, -1)]
        [InlineData(5, 2, -3, 4, -3)]
        [InlineData(8, 0, 3, 4, 0)]
        [InlineData(7, 5, 3, 4, 3)]
        public void GetSmallestNumber(int num1, int num2, int num3, int num4, int expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            int actual = challenger.GetSmallestNumber(num1, num2, num3, num4);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("true coders")]
        [InlineData("truecoders")]
        [InlineData("TRUECODERS")]
        [InlineData("tRUEcODERS")]
        [InlineData("test")]
        [InlineData("")]
        [InlineData(null)]
        public void ChangeBusinessNameTo_TrueCoders(string originalBusinessName)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();
            Business business = new Business() { Name = originalBusinessName };

            // Act
            challenger.ChangeBusinessNameTo_TrueCoders(business);

            // Assert
            Assert.Equal("TrueCoders", business.Name);
        }

        [Theory]
        [InlineData(2, 2, 2, true)]
        [InlineData(2, 3, 2, true)]
        [InlineData(3, 4, 5, true)]
        [InlineData(16, 10, 7, true)]
        [InlineData(30, 15, 20, true)]
        [InlineData(50, 30, 40, true)]
        [InlineData(100, 99, 2, true)]
        [InlineData(1000, 1, 1000, true)]
        [InlineData(100, 1, 99, false)]
        [InlineData(1, 19, 20, false)]
        [InlineData(85, 84, 1, false)]
        [InlineData(300, 400, 800, false)]
        [InlineData(2, 2, 0, false)]
        [InlineData(2, 0, 2, false)]
        [InlineData(0, 2, 2, false)]
        [InlineData(0, 0, 0, false)]
        [InlineData(-2, -2, -2, false)]
        [InlineData(-2, 2, 2, false)]
        [InlineData(10, 20, 50, false)]
        public void CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3, bool expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            bool actual = challenger.CouldFormTriangle(sideLength1, sideLength2, sideLength3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0", true)]
        [InlineData("123", true)]
        [InlineData("123.45", true)]
        [InlineData("-543", true)]
        [InlineData("-987.65", true)]
        [InlineData("abc", false)]
        [InlineData("77a", false)]
        [InlineData("a55", false)]
        [InlineData("22*", false)]
        [InlineData("4#", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsStringANumber(string word, bool expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            bool actual = challenger.IsStringANumber(word);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new string[] { "test", null, "test" }, false)]
        [InlineData(new string[] { "test", null, "test", null }, false)]
        [InlineData(new string[] { null, "test" }, false)]
        [InlineData(new string[] { null, "test", "test" }, false)]
        [InlineData(new string[] { "test", "test", "test" }, false)]
        [InlineData(new string[] { "test", "test", null }, false)]
        [InlineData(new object[] { 1, null, 7, "test" }, false)]
        [InlineData(new object[] { 1, null, '7', "test" }, false)]
        [InlineData(new object[] { 1, null, 'a', false, "test" }, false)]
        [InlineData(new object[] { null, "test", "test" }, false)]
        [InlineData(new object[] { null, "test", "test", null, "test" }, false)]
        [InlineData(new string[] { null, "test", "test", null, null }, true)]
        [InlineData(new string[] { null, null, "test", null, "test" }, true)]
        [InlineData(new string[] { null, "test", null, "test", null }, true)]
        [InlineData(new object[] { 1, null, null }, true)]
        [InlineData(new object[] { null, null, null }, true)]
        [InlineData(new object[] { null, null, 5, null }, true)]
        [InlineData(new object[] { null, null, 5, null, "test" }, true)]
        [InlineData(new object[] { null, null, "test", null, true }, true)]
        [InlineData(new object[] { null, null, '!', null, 4 }, true)]
        [InlineData(new object[] { null, false, null, null, '!', null, 4 }, true)]
        [InlineData(new object[] { null, null, new int[] { }, false, null, null, '!', null, 4 }, true)]
        public void MajorityOfElementsInArrayAreNull(object[] objects, bool expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            bool actual = challenger.MajorityOfElementsInArrayAreNull(objects);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -3)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, 2.6666666666)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, -2.6666666666)]
        [InlineData(new int[] { 1, -2, 2, 3, -4 }, -1.3333333333)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void AverageEvens(int[] numbers, double expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            double actual = challenger.AverageEvens(numbers);

            // Assert
            Assert.Equal(Math.Round(expected, 5), Math.Round(actual, 5));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(7, 5040)]
        [InlineData(8, 40320)]
        [InlineData(9, 362880)]
        [InlineData(10, 3628800)]
        public void Factorial(int number, int expected)
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();

            // Act
            int actual = challenger.Factorial(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
            // Arrange
            ChallengesSet04 challenger = new ChallengesSet04();
            int negative1 = -1;
            int negative2 = -2;
            int negative3 = -3;

            // Act
            Action actual1 = () => challenger.Factorial(negative1);
            Action actual2 = () => challenger.Factorial(negative2);
            Action actual3 = () => challenger.Factorial(negative3);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(actual1);
            Assert.Throws<ArgumentOutOfRangeException>(actual2);
            Assert.Throws<ArgumentOutOfRangeException>(actual3);
        }
    }
}
