using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

//superclass and trivial factory pattern example that creates both subclasses.   
public class GenClass
{

  GenClass gen;
  public GenClass()
  {
    
    
  }
  public GenClass(String arg)
  {
 
  }

  //create (factory method)
  public GenClass createObj(String arg)
  {
    if (arg.Equals("class1"))
    {
      gen = new Class1();
    }
    else
    {
      gen = new Class2();
    }
    return gen;
  }



  public GenClass getObj()
  {
    return gen; 
  }

  public virtual String getString()
  {
    return "";
  }

  //Builder Pattern method
  public ClassBuilder createClass(ClassBuilder builder)
  {
    builder.buildA();
    builder.buildB();
    builder.buildC();
    return builder; 
  }

}