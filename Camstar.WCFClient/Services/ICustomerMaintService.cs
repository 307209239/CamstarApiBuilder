// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICustomerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICustomerMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_LoadESigDetails_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Parameters parameters,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CustomerMaintMethod[] methods,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CustomerMaint customerMaint,
      CustomerMaint_Request request,
      out CustomerMaint_Result result);
  }
}
