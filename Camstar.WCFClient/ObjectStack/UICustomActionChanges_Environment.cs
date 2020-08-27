// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UICustomActionChanges_Environment
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
  public class UICustomActionChanges_Environment : UIActionChanges_Environment
  {
    [Metadata("UI Custom Action", "UICustomAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_ListItemToChange")]
    [Metadata("UI Custom Action", "UICustomActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_Parameters")]
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1050947, false, false, false, null)]
    protected Environment _Parameters;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_CustomMethodHandler")]
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052802, false, false, false, null)]
    protected Environment _CustomMethodHandler;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_IsReturn")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052797, false, false, false, "0")]
    protected Environment _IsReturn;
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_ClearValues")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052798, false, false, false, "0")]
    protected Environment _ClearValues;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052781, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UICustomActionChanges_Environment_Name")]
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

    public Environment Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parameters));
      }
    }

    public Environment CustomMethodHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomMethodHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CustomMethodHandler));
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
