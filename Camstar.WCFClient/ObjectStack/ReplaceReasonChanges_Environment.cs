// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReplaceReasonChanges_Environment
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
  public class ReplaceReasonChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, false, "String", 16778956, false, false, false, null)]
    protected new Environment _FilterTags;
    [Metadata("Reason codes for replacing container", "ReplaceReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_Environment_IsScrapRemoved")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16779385, false, false, false, "0")]
    protected Environment _IsScrapRemoved;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 16779383, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ReplaceReasonChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
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

    public Environment IsScrapRemoved
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsScrapRemoved), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsScrapRemoved));
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
