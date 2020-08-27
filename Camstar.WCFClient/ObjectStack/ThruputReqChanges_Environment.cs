// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputReqChanges_Environment
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
  public class ThruputReqChanges_Environment : MaintenanceReqChanges_Environment
  {
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048630, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("The user code for unit of material.", "UOM", false, true, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_UOM")]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_Base")]
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReqBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_Qty2")]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_ToleranceQty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050694, false, false, false, null)]
    protected Environment _ToleranceQty2;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_WarningQty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050696, false, false, false, null)]
    protected Environment _WarningQty2;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050695, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_WarningQty")]
    protected Environment _WarningQty;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050693, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_ToleranceQty")]
    protected Environment _ToleranceQty;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050697, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Material quantity (individual)", "", false, true, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqChanges_Environment_Qty")]
    protected Environment _Qty;

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

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public Environment ToleranceQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToleranceQty2));
      }
    }

    public Environment WarningQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WarningQty2));
      }
    }

    public Environment WarningQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (WarningQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WarningQty));
      }
    }

    public Environment ToleranceQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToleranceQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToleranceQty));
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

    public Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
