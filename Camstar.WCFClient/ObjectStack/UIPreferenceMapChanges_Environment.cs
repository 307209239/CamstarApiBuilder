// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPreferenceMapChanges_Environment
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
  public class UIPreferenceMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", false, true, false, "NamedObjectRef", 1051577, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_Environment_UIPreference")]
    protected Environment _UIPreference;
    [Metadata("The UI (User Interface) Preference Map object is used to store references between Organization and UI Preference.", "UIPreferenceMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_Environment_ListItemToChange")]
    [Metadata("UI Preference Map", "UIPreferenceMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_Environment_RecordType")]
    [Metadata("Enumeration for the Quality History Record Type:\r\n1 = Event\r\n2 = CAR\r\n3 = CAPA", "QualityHistoryRecordTypeEnum", false, true, false, "Integer", 1051578, false, false, true, null)]
    protected Environment _RecordType;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIPreference));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordType));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
