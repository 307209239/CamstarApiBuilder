// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigServiceDetail_Environment
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
  public class ESigServiceDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The type of verification that must occur to validate an Electronic Signature.\r\n1 = Password Verification\r\n2 = Badge Verification (future enhancement)\r\n3 = Biometric Verification (future enhancement)", "ESigVerificationMethodEnum", false, false, true, "Integer", 1050344, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_VerificationMethod")]
    protected Environment _VerificationMethod;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_Role")]
    protected Environment _Role;
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, false, true, "NamedObjectRef", 1050341, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_Meaning")]
    protected Environment _Meaning;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050340, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_CosignerRole")]
    protected Environment _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_CaptureDetails")]
    [Metadata("The signatures collected for an ESigReqDetail.", "ESigCaptureDetail", false, false, false, "ESigCaptureDetail", 1050367, false, true, false, null)]
    protected ESigCaptureDetail_Environment _CaptureDetails;
    [Metadata("The detailed requirements for an Electronic Signature requirement.  Each detail will require a unique signature when the requirement is implemented in a service.", "ESigReqDetail", false, true, false, "NamedSubentityRef", 1050360, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_ESigReqDetail")]
    protected Environment _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050343, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_SignatureCount")]
    protected Environment _SignatureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_CaptureCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050366, false, false, false, null)]
    protected Environment _CaptureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Environment_Qty")]
    protected Environment _Qty;

    public Environment VerificationMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (VerificationMethod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VerificationMethod));
      }
    }

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment Meaning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Meaning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Meaning));
      }
    }

    public Environment CosignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignerRole));
      }
    }

    public ESigCaptureDetail_Environment CaptureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureDetails), (object) value);
      }
      get
      {
        return (ESigCaptureDetail_Environment) this.PropertyGet(nameof (CaptureDetails));
      }
    }

    public Environment ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
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

    public Environment SignatureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignatureCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignatureCount));
      }
    }

    public Environment CaptureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CaptureCount));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
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
