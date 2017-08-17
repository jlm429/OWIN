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

  //create 
  public GenClass createObj(String arg)
  {
    if (arg.Equals("class1"))
    {
      gen = Class1Factory();
    }
    else
    {
      gen = Class2Factory();
    }
    return gen;
  }

  
  // factory methods
  //typically would be used to avoid subclassing
  //but these methods demonstrate the gist of the pattern
  public Class1 Class1Factory()
  {
    Class1 obj = new Class1();
    return obj; 
  }

  public Class2 Class2Factory()
  {
    Class2 obj2 = new Class2();
    return obj2; 
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