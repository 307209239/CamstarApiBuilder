// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserLabelChanges_Info
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
  public class UserLabelChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Info_LabelID")]
    protected Info _LabelID;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Info_LabelValue")]
    protected Info _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Info_CategoryID")]
    protected Info _CategoryID;
    [DataMember(EmitDefaultValue = false, Name = "UserLabelChanges_Info_Name")]
    protected new Info _Name;

    public Info LabelID
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

    public Info LabelValue
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

    public Info CategoryID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryID));
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
