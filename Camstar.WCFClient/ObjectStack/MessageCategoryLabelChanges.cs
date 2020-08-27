// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MessageCategoryLabelChanges
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
  public class MessageCategoryLabelChanges : UserLabelChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_LabelValue")]
    protected new Primitive<string> _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_LabelID")]
    protected new Primitive<int> _LabelID;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MessageCategoryLabelChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is MessageCategoryLabelChanges && object.Equals((object) this._LabelValue, (object) ((MessageCategoryLabelChanges) obj)._LabelValue) && (object.Equals((object) this._LabelID, (object) ((MessageCategoryLabelChanges) obj)._LabelID) && object.Equals((object) this._ObjectToChange, (object) ((MessageCategoryLabelChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((MessageCategoryLabelChanges) obj)._Name) && base.Equals(obj);
    }

    public new Primitive<string> LabelValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelValue));
      }
    }

    public new Primitive<int> LabelID
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelID));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
