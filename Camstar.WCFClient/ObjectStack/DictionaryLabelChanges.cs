// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DictionaryLabelChanges
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
  public class DictionaryLabelChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_LabelID")]
    protected Primitive<int> _LabelID;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_CategoryID")]
    protected Primitive<int> _CategoryID;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_LabelValue")]
    protected Primitive<string> _LabelValue;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_Name")]
    protected Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DictionaryLabelChanges_ActionMode")]
    protected Primitive<int> _ActionMode;

    public override bool Equals(object obj)
    {
      return obj is DictionaryLabelChanges && object.Equals((object) this._LabelID, (object) ((DictionaryLabelChanges) obj)._LabelID) && (object.Equals((object) this._CategoryID, (object) ((DictionaryLabelChanges) obj)._CategoryID) && object.Equals((object) this._DefaultValue, (object) ((DictionaryLabelChanges) obj)._DefaultValue)) && (object.Equals((object) this._LabelValue, (object) ((DictionaryLabelChanges) obj)._LabelValue) && object.Equals((object) this._Name, (object) ((DictionaryLabelChanges) obj)._Name) && object.Equals((object) this._ActionMode, (object) ((DictionaryLabelChanges) obj)._ActionMode)) && base.Equals(obj);
    }

    public Primitive<int> LabelID
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

    public Primitive<int> CategoryID
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CategoryID));
      }
    }

    public Primitive<string> DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Primitive<string> LabelValue
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

    public Primitive<string> Name
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

    public Primitive<int> ActionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionMode), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ActionMode));
      }
    }
  }
}
