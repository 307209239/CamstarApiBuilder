// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserCodeGroupMaintService : NamedObjectGroupMaintBase
  {
    public UserCodeGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserCodeGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).Delete(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.Delete(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Delete(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.Delete(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).Freeze(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.Freeze(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.Freeze(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.GetWIPMsgs(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.GetWIPMsgs(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).Load(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Load(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.Load(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus Load(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.Load(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_LoadESigDetails_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.LoadESigDetails, (UserCodeGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserCodeGroupMaint) null, (UserCodeGroupMaint_LoadESigDetails_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.LoadESigDetails(userCodeGroupMaint, (UserCodeGroupMaint_LoadESigDetails_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.LoadESigDetails(userCodeGroupMaint, (UserCodeGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).New(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus New(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.New(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus New(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.New(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).NewCopy(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.NewCopy(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.NewCopy(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).SaveAs(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.SaveAs(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.SaveAs(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).UnFreeze(this._UserProfile, userCodeGroupMaint, parameters, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(userCodeGroupMaint, UserCodeGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userCodeGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserCodeGroupMaint) null, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(UserCodeGroupMaint userCodeGroupMaint)
    {
      return this.UnFreeze(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.UnFreeze(userCodeGroupMaint, (UserCodeGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_LoadESigDetails_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userCodeGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserCodeGroupMaint) userCodeGroupMaint, (UserCodeGroupMaint_Parameters) parameters, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      try
      {
        UserCodeGroupMaintMethod[] methods = new UserCodeGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserCodeGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeGroupMaint cdo,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      try
      {
        return ((IUserCodeGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserCodeGroupMaint) cdo, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.GetEnvironment((UserCodeGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeGroupMaint cdo,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      result = (UserCodeGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserCodeGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserCodeGroupMaintMethod(cdo, UserCodeGroupMaintMethods.ExecuteTransaction, (UserCodeGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserCodeGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserCodeGroupMaint) cdo, (UserCodeGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserCodeGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserCodeGroupMaint_Request) null, out UserCodeGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result)
    {
      return this.ExecuteTransaction((UserCodeGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserCodeGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserCodeGroupMaintMethod(cdo, UserCodeGroupMaintMethods.AddDataTransaction, (UserCodeGroupMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((UserCodeGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
