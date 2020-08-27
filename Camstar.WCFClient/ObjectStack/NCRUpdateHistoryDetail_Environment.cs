// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistoryDetail_Environment
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
  public class NCRUpdateHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_CorrectiveActionHistory")]
    [Metadata("Corrective action history comments.", "NCRCorrectiveActionHistory", false, false, true, "SubentityRef", 1050441, false, false, false, null)]
    protected Environment _CorrectiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_NCRResolution")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1050440, false, false, false, null)]
    protected Environment _NCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_FailureInvestigationHistory")]
    [Metadata("Failure investigation history comments.", "NCRFailureInvestigationHistory", false, false, true, "SubentityRef", 1050443, false, false, false, null)]
    protected Environment _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_PreventiveActionHistory")]
    [Metadata("Preventive action history comments.", "NCRPreventiveActionHistory", false, false, true, "SubentityRef", 1050442, false, false, false, null)]
    protected Environment _PreventiveActionHistory;
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050424, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_NCRFailureType")]
    protected Environment _NCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050427, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_NCRCauseCode")]
    protected Environment _NCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_RelatedNonconformance")]
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050603, false, false, false, null)]
    protected Environment _RelatedNonconformance;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_NCRFailureCodes")]
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050439, false, true, false, null)]
    protected Environment _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_ChargeToStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_IsPreHistory")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050438, false, false, false, "0")]
    protected Environment _IsPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_CorrectiveActionComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050433, false, false, false, null)]
    protected Environment _CorrectiveActionComments;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050432, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_PreventiveActionComments")]
    protected Environment _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_NCRComment")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _NCRComment;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistoryDetail_Environment_FailureInvestigationComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050434, false, false, false, null)]
    protected Environment _FailureInvestigationComments;

    public Environment CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public Environment NCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRResolution));
      }
    }

    public Environment FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public Environment PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public Environment NCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureType));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment NCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRCauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRCauseCode));
      }
    }

    public Environment RelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelatedNonconformance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelatedNonconformance));
      }
    }

    public Environment NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public Environment ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment IsPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPreHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsPreHistory));
      }
    }

    public Environment CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Environment PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Environment NCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRComment));
      }
    }

    public Environment FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }
  }
}
