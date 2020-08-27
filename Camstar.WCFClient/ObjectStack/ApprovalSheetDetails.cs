// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetDetails
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
  public class ApprovalSheetDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_GeneralInstructions")]
    protected Primitive<string> _GeneralInstructions;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Name")]
    protected Enumeration<QualityTransitionsEnum, string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_ApprovalDecisionList")]
    protected NamedObjectRef _ApprovalDecisionList;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Status")]
    protected Enumeration<ApprovalStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_ApprovalEntries")]
    protected ApprovalEntryDetails[] _ApprovalEntries;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_ApprovalSheet")]
    protected NamedSubentityRef _ApprovalSheet;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_AutoStart")]
    protected Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_ExecuteAction")]
    protected Primitive<int> _ExecuteAction;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetDetails_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is ApprovalSheetDetails && object.Equals((object) this._GeneralInstructions, (object) ((ApprovalSheetDetails) obj)._GeneralInstructions) && (object.Equals((object) this._Name, (object) ((ApprovalSheetDetails) obj)._Name) && object.Equals((object) this._ApprovalDecisionList, (object) ((ApprovalSheetDetails) obj)._ApprovalDecisionList)) && (object.Equals((object) this._Status, (object) ((ApprovalSheetDetails) obj)._Status) && this.CompareArrays((Array) this._ApprovalEntries, (Array) ((ApprovalSheetDetails) obj)._ApprovalEntries) && (object.Equals((object) this._ApprovalSheet, (object) ((ApprovalSheetDetails) obj)._ApprovalSheet) && object.Equals((object) this._ApprovalRequired, (object) ((ApprovalSheetDetails) obj)._ApprovalRequired))) && (object.Equals((object) this._AutoStart, (object) ((ApprovalSheetDetails) obj)._AutoStart) && object.Equals((object) this._ExecuteAction, (object) ((ApprovalSheetDetails) obj)._ExecuteAction) && object.Equals((object) this._Description, (object) ((ApprovalSheetDetails) obj)._Description)) && base.Equals(obj);
    }

    public Primitive<string> GeneralInstructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralInstructions), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralInstructions));
      }
    }

    public Enumeration<QualityTransitionsEnum, string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Enumeration<QualityTransitionsEnum, string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedObjectRef ApprovalDecisionList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecisionList), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalDecisionList));
      }
    }

    public Enumeration<ApprovalStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<ApprovalStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public ApprovalEntryDetails[] ApprovalEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalEntries), (object) value);
      }
      get
      {
        return (ApprovalEntryDetails[]) this.PropertyGet(nameof (ApprovalEntries));
      }
    }

    public NamedSubentityRef ApprovalSheet
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheet), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalSheet));
      }
    }

    public Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public Primitive<bool> AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Primitive<int> ExecuteAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteAction), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecuteAction));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
