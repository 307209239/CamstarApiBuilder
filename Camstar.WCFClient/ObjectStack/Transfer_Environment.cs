// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Transfer_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Transfer_Environment : MoveNonStd_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Environment_Close")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049202, false, false, false, "0")]
    protected new Environment _Close;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050386, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Environment_UseDispatch")]
    protected new Environment _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Environment_ToLocation")]
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1049216, false, false, true, null)]
    protected new Environment _ToLocation;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, true, "NamedObjectRef", 1049677, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Transfer_Environment_ToFactory")]
    protected new Environment _ToFactory;

    public new Environment Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Close));
      }
    }

    public new Environment UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public new Environment ToLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToLocation));
      }
    }

    public new Environment ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToFactory));
      }
    }
  }
}
