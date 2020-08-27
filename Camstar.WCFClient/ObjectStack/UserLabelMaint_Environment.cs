// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserLabelMaint_Environment
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
  public class UserLabelMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Labels that do not exist in any form in the Designer, but are defined as instance data.    It belongs to default label and is in a special label category: OtherUserLabel.  New label ID is created using a server side API call.", "UserLabel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_Environment_LabelNameFilter")]
    [Metadata("DisplayName", "", false, false, false, "String", 1049971, false, false, false, null)]
    protected Environment _LabelNameFilter;
    [Metadata("Labels that do not exist in any form in the Designer, but are defined as instance data.    It belongs to default label and is in a special label category: OtherUserLabel.  New label ID is created using a server side API call.", "UserLabel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_Environment_LabelValueFilter")]
    [Metadata("DisplayName", "", false, false, false, "String", 1049970, false, false, false, null)]
    protected Environment _LabelValueFilter;
    [Metadata("Labels that do not exist in any form in the Designer, but are defined as instance data.    It belongs to default label and is in a special label category: OtherUserLabel.  New label ID is created using a server side API call.", "UserLabelChanges", false, false, false, "UserLabelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserLabelMaint_Environment_ObjectChanges")]
    protected UserLabelChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Environment LabelNameFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelNameFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelNameFilter));
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

    public Environment LabelValueFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValueFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelValueFilter));
      }
    }

    public UserLabelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UserLabelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
