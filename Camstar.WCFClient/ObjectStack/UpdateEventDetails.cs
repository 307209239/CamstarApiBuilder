// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventDetails
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
  public class UpdateEventDetails : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDetails_QualityObject")]
    protected new NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDetails_SubClassification")]
    protected NamedObjectRef _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDetails_Classification")]
    protected NamedObjectRef _Classification;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDetails_ActionSelectedTab")]
    protected Primitive<int> _ActionSelectedTab;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventDetails && object.Equals((object) this._QualityObject, (object) ((UpdateEventDetails) obj)._QualityObject) && (object.Equals((object) this._SubClassification, (object) ((UpdateEventDetails) obj)._SubClassification) && object.Equals((object) this._Classification, (object) ((UpdateEventDetails) obj)._Classification)) && object.Equals((object) this._ActionSelectedTab, (object) ((UpdateEventDetails) obj)._ActionSelectedTab) && base.Equals(obj);
    }

    public new NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public NamedObjectRef SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubClassification));
      }
    }

    public NamedObjectRef Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Classification));
      }
    }

    public Primitive<int> ActionSelectedTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSelectedTab), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ActionSelectedTab));
      }
    }
  }
}
