// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDetails
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
  public class ResourceStatusDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Availability")]
    protected Primitive<string> _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_ResourceAvailability")]
    protected Primitive<int> _ResourceAvailability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_ReasonCodeName")]
    protected Primitive<string> _ReasonCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Status")]
    protected NamedObjectRef _Status;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_TimeAtStatus")]
    protected Primitive<double> _TimeAtStatus;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Product")]
    protected RevisionedObjectRef _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_SetupRev")]
    protected Primitive<string> _SetupRev;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_StatusCodeName")]
    protected Primitive<string> _StatusCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Reason")]
    protected NamedObjectRef _Reason;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Run")]
    protected Primitive<string> _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Setup")]
    protected RevisionedObjectRef _Setup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_SetupName")]
    protected Primitive<string> _SetupName;

    public override bool Equals(object obj)
    {
      return obj is ResourceStatusDetails && object.Equals((object) this._Availability, (object) ((ResourceStatusDetails) obj)._Availability) && (object.Equals((object) this._ResourceAvailability, (object) ((ResourceStatusDetails) obj)._ResourceAvailability) && object.Equals((object) this._ProductRev, (object) ((ResourceStatusDetails) obj)._ProductRev)) && (object.Equals((object) this._ReasonCodeName, (object) ((ResourceStatusDetails) obj)._ReasonCodeName) && object.Equals((object) this._ProductName, (object) ((ResourceStatusDetails) obj)._ProductName) && (object.Equals((object) this._Status, (object) ((ResourceStatusDetails) obj)._Status) && object.Equals((object) this._TimeAtStatus, (object) ((ResourceStatusDetails) obj)._TimeAtStatus))) && (object.Equals((object) this._Product, (object) ((ResourceStatusDetails) obj)._Product) && object.Equals((object) this._SetupRev, (object) ((ResourceStatusDetails) obj)._SetupRev) && (object.Equals((object) this._StatusCodeName, (object) ((ResourceStatusDetails) obj)._StatusCodeName) && object.Equals((object) this._Reason, (object) ((ResourceStatusDetails) obj)._Reason)) && (object.Equals((object) this._Run, (object) ((ResourceStatusDetails) obj)._Run) && object.Equals((object) this._Setup, (object) ((ResourceStatusDetails) obj)._Setup) && object.Equals((object) this._SetupName, (object) ((ResourceStatusDetails) obj)._SetupName))) && base.Equals(obj);
    }

    public Primitive<string> Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Availability));
      }
    }

    public Primitive<int> ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResourceAvailability));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Primitive<string> ReasonCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReasonCodeName));
      }
    }

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public NamedObjectRef Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<double> TimeAtStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimeAtStatus), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (TimeAtStatus));
      }
    }

    public RevisionedObjectRef Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Product));
      }
    }

    public Primitive<string> SetupRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SetupRev));
      }
    }

    public Primitive<string> StatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusCodeName));
      }
    }

    public NamedObjectRef Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Reason));
      }
    }

    public Primitive<string> Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Run));
      }
    }

    public RevisionedObjectRef Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Setup));
      }
    }

    public Primitive<string> SetupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SetupName));
      }
    }
  }
}
