// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRUpdateHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRCloseHistory_Environment))]
  [Serializable]
  public class NCRUpdateHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050590, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreNCRCauseCode")]
    protected Environment _PreNCRCauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostNCRResolution")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1050585, false, false, false, null)]
    protected Environment _PostNCRResolution;
    [Metadata("Detail history of the NCRUpdate service.", "NCRUpdateHistoryDetail", false, false, true, "SubentityRef", 1050566, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_NCRUpdateHistoryDetails")]
    protected Environment _NCRUpdateHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostChargeToStep")]
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1050577, false, false, false, null)]
    protected Environment _PostChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreNCRFailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050593, false, false, false, null)]
    protected Environment _PreNCRFailureType;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050596, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreRelatedNonconformance")]
    protected Environment _PreRelatedNonconformance;
    [Metadata("The NonconformanceReport (NCR) is used to track Non-conforming material.  It includes attributes for analytic data (Failure, Cause, Resolution, etc) as well as attributes to identify the material that failed (Container and component information).", "NonconformanceReport", false, false, true, "NamedObjectRef", 1050586, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostRelatedNonconformance")]
    protected Environment _PostRelatedNonconformance;
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050583, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostNCRFailureCodes")]
    protected Environment _PostNCRFailureCodes;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, true, "NamedSubentityRef", 1050587, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreChargeToStep")]
    protected Environment _PreChargeToStep;
    [Metadata("NCR defect history details.", "NCRDefectHistoryDetails", false, false, false, "NCRDefectHistoryDetails", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_HistoryDetails")]
    protected NCRDefectHistoryDetails_Environment _HistoryDetails;
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1050594, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreNCRResolution")]
    protected Environment _PreNCRResolution;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreNCRFailureCodes")]
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050592, false, true, false, null)]
    protected Environment _PreNCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostNCRFailureType")]
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, true, "NamedObjectRef", 1050584, false, false, false, null)]
    protected Environment _PostNCRFailureType;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostNCRCauseCode")]
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050581, false, false, false, null)]
    protected Environment _PostNCRCauseCode;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050580, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostPreventiveActionComments")]
    protected Environment _PostPreventiveActionComments;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050578, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostCorrectiveActionComments")]
    protected Environment _PostCorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostFailureInvestigationComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050579, false, false, false, null)]
    protected Environment _PostFailureInvestigationComments;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050595, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PrePreventiveActionComments")]
    protected Environment _PrePreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreNCRComment")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050591, false, false, false, null)]
    protected Environment _PreNCRComment;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050589, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreFailureInvestigationComments")]
    protected Environment _PreFailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PreCorrectiveActionComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050588, false, false, false, null)]
    protected Environment _PreCorrectiveActionComments;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050582, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRUpdateHistory_Environment_PostNCRComment")]
    protected Environment _PostNCRComment;

    public Environment PreNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRCauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreNCRCauseCode));
      }
    }

    public Environment PostNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRResolution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostNCRResolution));
      }
    }

    public Environment NCRUpdateHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRUpdateHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRUpdateHistoryDetails));
      }
    }

    public Environment PostChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostChargeToStep));
      }
    }

    public Environment PreNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreNCRFailureType));
      }
    }

    public Environment PreRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreRelatedNonconformance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreRelatedNonconformance));
      }
    }

    public Environment PostRelatedNonconformance
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostRelatedNonconformance), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostRelatedNonconformance));
      }
    }

    public Environment PostNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostNCRFailureCodes));
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

    public Environment PreChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreChargeToStep));
      }
    }

    public NCRDefectHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Environment PreNCRResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRResolution), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreNCRResolution));
      }
    }

    public Environment PreNCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRFailureCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreNCRFailureCodes));
      }
    }

    public Environment PostNCRFailureType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRFailureType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostNCRFailureType));
      }
    }

    public Environment PostNCRCauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRCauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostNCRCauseCode));
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

    public Environment PostPreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostPreventiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostPreventiveActionComments));
      }
    }

    public Environment PostCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostCorrectiveActionComments));
      }
    }

    public Environment PostFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostFailureInvestigationComments));
      }
    }

    public Environment PrePreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrePreventiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrePreventiveActionComments));
      }
    }

    public Environment PreNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreNCRComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreNCRComment));
      }
    }

    public Environment PreFailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreFailureInvestigationComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreFailureInvestigationComments));
      }
    }

    public Environment PreCorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreCorrectiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreCorrectiveActionComments));
      }
    }

    public Environment PostNCRComment
    {
      [param: In] set
      {
        this.PropertySet(nameof (PostNCRComment), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PostNCRComment));
      }
    }
  }
}
