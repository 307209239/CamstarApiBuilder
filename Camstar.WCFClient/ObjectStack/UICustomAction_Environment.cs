// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UICustomAction_Environment
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
  public class UICustomAction_Environment : UIAction_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Environment_CustomMethodHandler")]
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052802, false, false, false, null)]
    protected Environment _CustomMethodHandler;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1050947, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Environment_Parameters")]
    protected Environment _Parameters;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052798, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Environment_ClearValues")]
    protected Environment _ClearValues;
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Environment_IsReturn")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052797, false, false, false, "0")]
    protected Environment _IsReturn;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052781, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UICustomAction_Environment_Name")]
    protected new Environment _Name;

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
