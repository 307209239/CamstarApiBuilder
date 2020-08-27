// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigChanges_Environment
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
  public class WhereUsedConfigChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Configuration object used in object upward dependency search.", "WhereUsedConfig", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Environment_WhereUsedConfigDetails")]
    [Metadata("List of configurations used in upward dependency search.", "WhereUsedConfigDetailsChanges", false, false, false, "WhereUsedConfigDetailsChanges", 16778017, false, true, false, null)]
    protected WhereUsedConfigDetailsChanges_Environment _WhereUsedConfigDetails;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16778014, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Environment_Name")]
    protected new Environment _Name;

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

    public WhereUsedConfigDetailsChanges_Environment WhereUsedConfigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfigDetails), (object) value);
      }
      get
      {
        return (WhereUsedConfigDetailsChanges_Environment) this.PropertyGet(nameof (WhereUsedConfigDetails));
      }
    }

    public new Environment Name
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
  }
}
