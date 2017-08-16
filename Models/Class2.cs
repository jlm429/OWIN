using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class2
/// </summary>
public class Class2 : GenClass
{
  String test; 
  public Class2()
  {

    test = "class2";
  }

  public override String getString()
  {
    return test; 
  }
}