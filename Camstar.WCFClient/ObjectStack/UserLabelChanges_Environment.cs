// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserLabelChanges_Environment
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
  public class UserLabelChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Environment_LabelID")]
    [Metadata("LabelId", "", false, false, true, "Integer", 1049968, false, false, false, null)]
    protected Environment _LabelID;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Environment_LabelValue")]
    [Metadata("Label Value.", "", false, true, false, "String", 1049969, false, false, false, null)]
    protected Environment _LabelValue;
    [Metadata("Labels that do not exist in any form in the Designer, but are defined as instance data.    It belongs to default label and is in a special label category: OtherUserLabel.  New label ID is created using a server side API call.", "UserLabel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Environment_CategoryID")]
    [Metadata("LabelCategoryId", "", false, false, true, "Integer", 1049636, false, false, false, "75")]
    protected Environment _CategoryID;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050126, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment LabelID
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelID));
      }
    }

    public Environment LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelValue));
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

    public Environment CategoryID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryID));
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
