﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISellReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISellReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_LoadESigDetails_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Parameters parameters,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SellReasonMaintMethod[] methods,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SellReasonMaint sellReasonMaint,
      SellReasonMaint_Request request,
      out SellReasonMaint_Result result);
  }
}
