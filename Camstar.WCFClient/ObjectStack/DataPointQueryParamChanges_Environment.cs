// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointQueryParamChanges_Environment
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
  public class DataPointQueryParamChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Data Point that calls for identifying an InSite object.", "ObjectDataPoint", false, false, false, "NamedSubentityRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_Parent")]
    protected new Environment _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_ParameterExpression")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1050882, false, false, false, null)]
    protected Environment _ParameterExpression;
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_ListItemToChange")]
    [Metadata("The DataPointQueryParam contains a reference to the parameter name and an expression that is evaluated (at collection time) to provide the value for the parameter.", "DataPointQueryParamChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("The DataPointQueryParam contains a reference to the parameter name and an expression that is evaluated (at collection time) to provide the value for the parameter.", "DataPointQueryParam", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050881, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointQueryParamChanges_Environment_ParameterName")]
    protected Environment _ParameterName;

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment ParameterExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterExpression));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment ParameterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterName));
      }
    }
  }
}
