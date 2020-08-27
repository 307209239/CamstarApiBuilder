// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventCrossRefs_Info
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
  public class UpdateEventCrossRefs_Info : UpdateEventDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventCrossRefs_Info_QualityCrossReferences")]
    protected QualityCrossReferenceDetail_Info _QualityCrossReferences;

    public QualityCrossReferenceDetail_Info QualityCrossReferences
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityCrossReferences), (object) value);
      }
      get
      {
        return (QualityCrossReferenceDetail_Info) this.PropertyGet(nameof (QualityCrossReferences));
      }
    }
  }
}
