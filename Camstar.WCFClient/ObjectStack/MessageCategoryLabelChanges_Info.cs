// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MessageCategoryLabelChanges_Info
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
  public class MessageCategoryLabelChanges_Info : UserLabelChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Info_LabelValue")]
    protected new Info _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Info_LabelID")]
    protected new Info _LabelID;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Info_Name")]
    protected new Info _Name;

    public new Info LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelValue));
      }
    }

    public new Info LabelID
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelID));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
