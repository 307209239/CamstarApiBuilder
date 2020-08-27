// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateDisposition_Environment
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
  public class ActivityTemplateDisposition_Environment : ActivityTemplate_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Environment_Disposition")]
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, false, "NamedObjectRef", 1051582, false, false, false, null)]
    protected Environment _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Environment_DisplayConformingQuantity")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052019, false, false, false, "0")]
    protected Environment _DisplayConformingQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Environment_ReconcileQuantity")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052020, false, false, false, "0")]
    protected Environment _ReconcileQuantity;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateDisposition_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;

    public Environment Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Disposition));
      }
    }

    public Environment DisplayConformingQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayConformingQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayConformingQuantity));
      }
    }

    public Environment ReconcileQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReconcileQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReconcileQuantity));
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
