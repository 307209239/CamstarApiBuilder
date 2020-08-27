// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMoveStdChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMoveStdChangePkgService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_LoadESigDetails_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Parameters parameters,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MoveStdChangePkgMethod[] methods,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MoveStdChangePkg moveStdChangePkg,
      MoveStdChangePkg_Request request,
      out MoveStdChangePkg_Result result);
  }
}
