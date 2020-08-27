// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistViewHistMainlineDtlChanges_Environment
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
  public class HistViewHistMainlineDtlChanges_Environment : HistViewDtlChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HistViewHistMainlineDtlChanges_Environment_ObjectToChange")]
    [Metadata("User Interface (UI) Preference History Mainline Detail is used to store the fields that are related to a UI Preference instance for the History Mainline.  This UI Preference is used to store the fields to be displayed for the History Mainline section in the Live History.", "HistViewHistMainlineDtl", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Changes CDO for UI Pref His Mainline Dtl", "HistViewHistMainlineDtlChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistViewHistMainlineDtlChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050254, false, false, false, "HistoryMainline")]
    [DataMember(EmitDefaultValue = false, Name = "HistViewHistMainlineDtlChanges_Environment_Name")]
    protected new Environment _Name;

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
