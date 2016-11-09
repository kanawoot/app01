using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace App01.Facts {
  public class CalculatorCalculator {

    public class AddMethod {


      [Fact]
      public void OneDigit_1() {

        // Arrange
        var c = new Calculator();

        // Act
        var result = c.Add("1", "1");

        // Assert
        Assert.Equal("2", result);

      }

      [Fact]
      public void OneDigit_2() {

        // Arrange
        var c = new Calculator();

        // Act
        var result = c.Add("2", "2");

        // Assert
        Assert.Equal("4", result);

      }

      [Fact]
      public void NegativeValues() {

        // Arrange
        var c = new Calculator();

        // Act
        var result = c.Add("-5", "8");

        // Assert
        Assert.Equal("3", result);

      }

      [Fact]
      public void EmptyStringOrNull_TreatAsZero() {

        // Arrange
        var c = new Calculator();

        // Act
        var result1 = c.Add(null, "9");
        var result2 = c.Add("", "9");
        var result3 = c.Add("99", null);
        var result4 = c.Add("99", "");

        // Assert
        Assert.Equal("9", result1);
        Assert.Equal("9", result2);
        Assert.Equal("9", result3);
        Assert.Equal("9", result4);


      }


      [Fact]
      public void TwoDigit() {

        var c = new Calculator();
        var result = c.Add("11", "22");
        Assert.Equal("33", result);
      }


    }

  }
}

