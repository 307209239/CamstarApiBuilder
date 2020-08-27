// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPreferenceChanges_Environment
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
  public class UIPreferenceChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("The UI Preference Field Definition will be used to store the information about a User Interface field.  (Position, sequence, etc.)", "UIPrefFieldDefChanges", false, false, false, "UIPrefFieldDefChanges", 1050043, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_Environment_UIPrefFieldDefs")]
    protected UIPrefFieldDefChanges_Environment _UIPrefFieldDefs;
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPreferenceChanges_Environment_Name")]
    protected new Environment _Name;

    public UIPrefFieldDefChanges_Environment UIPrefFieldDefs
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPrefFieldDefs), (object) value);
      }
      get
      {
        return (UIPrefFieldDefChanges_Environment) this.PropertyGet(nameof (UIPrefFieldDefs));
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
