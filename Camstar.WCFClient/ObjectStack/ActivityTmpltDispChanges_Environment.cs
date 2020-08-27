// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispChanges_Environment
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
  public class ActivityTmpltDispChanges_Environment : ActivityTemplateChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_Disposition")]
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, false, "NamedObjectRef", 1051582, false, false, true, null)]
    protected Environment _Disposition;
    [Metadata("The template for disposition activities which record the disposition of material associated with QualityObject records.", "ActivityTemplateDisposition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_DispositionData")]
    [Metadata("DispositionDataChanges", "DispositionDataChanges", false, false, true, "DispositionDataChanges", 1051588, false, true, false, null)]
    protected DispositionDataChanges_Environment _DispositionData;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_DisplayConformingQuantity")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052019, false, false, false, "0")]
    protected Environment _DisplayConformingQuantity;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052020, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_ReconcileQuantity")]
    protected Environment _ReconcileQuantity;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispChanges_Environment_Name")]
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

    public DispositionDataChanges_Environment DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (DispositionDataChanges_Environment) this.PropertyGet(nameof (DispositionData));
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
