﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReturnedEquipmentActionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReturnedEquipmentActionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_LoadESigDetails_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReturnedEquipmentActionMaintMethod[] methods,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result);
  }
}
