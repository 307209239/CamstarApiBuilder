// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeAttributeDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ChgDurationListDetails_Environment))]
  [KnownType(typeof (ChgFloatDetails_Environment))]
  [KnownType(typeof (ChgBooleanListDetails_Environment))]
  [KnownType(typeof (ChgStringDetails_Environment))]
  [KnownType(typeof (ChgDurationDetails_Environment))]
  [KnownType(typeof (ChgIntegerListDetails_Environment))]
  [KnownType(typeof (ChgObjectListDetails_Environment))]
  [KnownType(typeof (ChgIntegerDetails_Environment))]
  [KnownType(typeof (ChgStringListDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ChgFixedDetails_Environment))]
  [KnownType(typeof (ChgTimeStampDetails_Environment))]
  [KnownType(typeof (ChgFixedListDetails_Environment))]
  [KnownType(typeof (ChgBooleanDetails_Environment))]
  [KnownType(typeof (ChgTimeStampListDetails_Environment))]
  [KnownType(typeof (ChgObjectDetails_Environment))]
  [KnownType(typeof (ChgFloatListDetails_Environment))]
  [Serializable]
  public class ChangeAttributeDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Field Expression.", "", false, true, false, "String", 1049129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeAttributeDetails_Environment_FieldName")]
    protected Environment _FieldName;

    public Environment FieldName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldName));
      }
    }
  }
}
