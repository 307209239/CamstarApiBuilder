﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IApplicationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IApplicationMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_LoadESigDetails_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Parameters parameters,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ApplicationMaintMethod[] methods,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ApplicationMaint applicationMaint,
      ApplicationMaint_Request request,
      out ApplicationMaint_Result result);
  }
}