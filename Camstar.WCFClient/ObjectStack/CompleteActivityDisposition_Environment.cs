// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteActivityDisposition_Environment
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
  public class CompleteActivityDisposition_Environment : CompleteActivity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Environment_ServiceDetails")]
    [Metadata("Disposition Detail", "DispositionDetail", false, false, false, "DispositionDetail", 1052101, false, true, false, null)]
    protected DispositionDetail_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Environment_ProcessObject")]
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, true, false, "NamedSubentityRef", 1050968, false, false, false, null)]
    protected new Environment _ProcessObject;
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, true, "NamedSubentityRef", 1050968, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Environment_Activity")]
    protected new Environment _Activity;
    [Metadata("Identifies the actions that can be taken on a Lot assigned to an Event.  Examples are Scrap, Rework, Return to Vendor.", "Disposition", false, false, true, "NamedObjectRef", 1051582, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Environment_Disposition")]
    protected Environment _Disposition;
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, true, "ActivityDisposition", 1051538, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteActivityDisposition_Environment_ProcessObjectDetails")]
    protected ActivityDisposition_Environment _ProcessObjectDetails;

    public DispositionDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (DispositionDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Environment ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessObject));
      }
    }

    public new Environment Activity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activity));
      }
    }

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

    public ActivityDisposition_Environment ProcessObjectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectDetails), (object) value);
      }
      get
      {
        return (ActivityDisposition_Environment) this.PropertyGet(nameof (ProcessObjectDetails));
      }
    }
  }
}
