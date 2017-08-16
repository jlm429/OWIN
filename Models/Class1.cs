using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1 : GenClass
{

  
  String test; 
  public Class1()
  {
    test = "class1";
  }

  public override String getString()
  {
    return test; 
  }
}