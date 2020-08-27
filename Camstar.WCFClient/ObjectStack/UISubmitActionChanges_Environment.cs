// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISubmitActionChanges_Environment
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
  public class UISubmitActionChanges_Environment : UIActionChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Environment_ObjectToChange")]
    [Metadata("UI Submit Action", "UISubmitAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("UI Submit Action", "UISubmitActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Environment_ClearValues")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052798, false, false, false, "0")]
    protected Environment _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Environment_IsReturn")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052797, false, false, false, "0")]
    protected Environment _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UISubmitActionChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052778, false, false, false, null)]
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

    public Environment ClearValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearValues));
      }
    }

    public Environment IsReturn
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReturn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsReturn));
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
