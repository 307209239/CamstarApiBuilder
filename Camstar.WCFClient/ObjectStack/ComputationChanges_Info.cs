// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationChanges_Info
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
  public class ComputationChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_ComputationExpression")]
    protected Info _ComputationExpression;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_ResultDataType")]
    protected Info _ResultDataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_ComputationParamSpecs")]
    protected ComputationParamSpecChanges_Info _ComputationParamSpecs;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_AttributeName")]
    protected Info _AttributeName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_MapToContainerAttribute")]
    protected Info _MapToContainerAttribute;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_DisplayLimits")]
    protected Info _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_IsLimitOverrideAllowed")]
    protected Info _IsLimitOverrideAllowed;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_ResultName")]
    protected Info _ResultName;
    [DataMember(EmitDefaultValue = false, Name = "ComputationChanges_Info_Name")]
    protected new Info _Name;

    public Info LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Info UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Info ComputationExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ComputationExpression));
      }
    }

    public Info ResultDataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultDataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultDataType));
      }
    }

    public ComputationParamSpecChanges_Info ComputationParamSpecs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParamSpecs), (object) value);
      }
      get
      {
        return (ComputationParamSpecChanges_Info) this.PropertyGet(nameof (ComputationParamSpecs));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info AttributeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttributeName));
      }
    }

    public Info MapToContainerAttribute
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapToContainerAttribute), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MapToContainerAttribute));
      }
    }

    public Info DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public Info IsLimitOverrideAllowed
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsLimitOverrideAllowed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsLimitOverrideAllowed));
      }
    }

    public Info ResultName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultName));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
