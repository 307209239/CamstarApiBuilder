// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MessageCategoryLabelChanges_Environment
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
  public class MessageCategoryLabelChanges_Environment : UserLabelChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Environment_LabelValue")]
    [Metadata("Label Value.", "", false, true, false, "String", 1052297, false, false, false, null)]
    protected new Environment _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Environment_LabelID")]
    [Metadata("LabelId", "", false, false, true, "Integer", 1052298, false, false, false, null)]
    protected new Environment _LabelID;
    [Metadata("Manages Categories available for use in PortalNotification.", "MessageCategoryLabel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052299, false, false, false, null)]
    protected new Environment _Name;

    public new Environment LabelValue
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

    public new Environment LabelID
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
