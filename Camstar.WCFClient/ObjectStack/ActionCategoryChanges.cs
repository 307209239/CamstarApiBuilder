// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionCategoryChanges
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
  public class ActionCategoryChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_LabelText")]
    protected Primitive<string> _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionCategoryChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActionCategoryChanges && object.Equals((object) this._Sequence, (object) ((ActionCategoryChanges) obj)._Sequence) && (object.Equals((object) this._LabelText, (object) ((ActionCategoryChanges) obj)._LabelText) && object.Equals((object) this._LabelName, (object) ((ActionCategoryChanges) obj)._LabelName)) && (object.Equals((object) this._ObjectToChange, (object) ((ActionCategoryChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((ActionCategoryChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<string> LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelText));
      }
    }

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
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
