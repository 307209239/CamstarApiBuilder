// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryStringParameterChanges_Environment
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
  public class QueryStringParameterChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Query String Parameter", "QueryStringParameter", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Environment_ListItemToChange")]
    [Metadata("Query String Parameter", "QueryStringParameterChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Environment_Name")]
    protected Environment _Name;
    [Metadata("Generic String", "", false, false, false, "String", 1052743, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Environment_SourceMember")]
    protected Environment _SourceMember;
    [DataMember(EmitDefaultValue = false, Name = "QueryStringParameterChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment SourceMember
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceMember), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceMember));
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
  }
}
