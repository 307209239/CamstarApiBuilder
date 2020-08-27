// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventCrossRefs
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
  public class UpdateEventCrossRefs : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventCrossRefs_QualityCrossReferences")]
    protected QualityCrossReferenceDetail[] _QualityCrossReferences;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventCrossRefs && this.CompareArrays((Array) this._QualityCrossReferences, (Array) ((UpdateEventCrossRefs) obj)._QualityCrossReferences) && base.Equals(obj);
    }

    public QualityCrossReferenceDetail[] QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail[]) this.PropertyGet(nameof (QualityCrossReferences));
      }
    }
  }
}
