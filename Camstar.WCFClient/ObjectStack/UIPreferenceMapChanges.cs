// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPreferenceMapChanges
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
  public class UIPreferenceMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_UIPreference")]
    protected NamedObjectRef _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_RecordType")]
    protected Enumeration<QualityHistoryRecordTypeEnum, int> _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIPreferenceMapChanges && object.Equals((object) this._UIPreference, (object) ((UIPreferenceMapChanges) obj)._UIPreference) && (object.Equals((object) this._ObjectToChange, (object) ((UIPreferenceMapChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((UIPreferenceMapChanges) obj)._ListItemToChange)) && (object.Equals((object) this._RecordType, (object) ((UIPreferenceMapChanges) obj)._RecordType) && object.Equals((object) this._IsFrozen, (object) ((UIPreferenceMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public NamedObjectRef UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIPreference));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<QualityHistoryRecordTypeEnum, int> RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Enumeration<QualityHistoryRecordTypeEnum, int>) this.PropertyGet(nameof (RecordType));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
