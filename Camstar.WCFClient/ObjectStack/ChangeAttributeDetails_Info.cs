// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgTimeStampListDetails_Info))]
  [KnownType(typeof (ChgStringDetails_Info))]
  [KnownType(typeof (ChgObjectListDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgBooleanDetails_Info))]
  [KnownType(typeof (ChgBooleanListDetails_Info))]
  [KnownType(typeof (ChgDurationDetails_Info))]
  [KnownType(typeof (ChgDurationListDetails_Info))]
  [KnownType(typeof (ChgIntegerDetails_Info))]
  [KnownType(typeof (ChgStringListDetails_Info))]
  [KnownType(typeof (ChgObjectDetails_Info))]
  [KnownType(typeof (ChgIntegerListDetails_Info))]
  [KnownType(typeof (ChgFixedDetails_Info))]
  [KnownType(typeof (ChgTimeStampDetails_Info))]
  [KnownType(typeof (ChgFixedListDetails_Info))]
  [KnownType(typeof (ChgFloatDetails_Info))]
  [KnownType(typeof (ChgFloatListDetails_Info))]
  [Serializable]
  public class ChangeAttributeDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeDetails_Info_FieldName")]
    protected Info _FieldName;

    public Info FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
