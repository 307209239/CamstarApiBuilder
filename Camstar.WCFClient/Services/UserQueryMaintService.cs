// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserQueryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserQueryMaintService : NamedDataObjectMaintBase
  {
    public UserQueryMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserQueryMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).Delete(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Delete(UserQueryMaint userQueryMaint)
    {
      return this.Delete(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Delete(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.Delete(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).Freeze(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Freeze(UserQueryMaint userQueryMaint)
    {
      return this.Freeze(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Freeze(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.Freeze(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserQueryMaint userQueryMaint)
    {
      return this.GetWIPMsgs(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.GetWIPMsgs(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).Load(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Load(UserQueryMaint userQueryMaint)
    {
      return this.Load(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus Load(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.Load(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_LoadESigDetails_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).LoadESigDetails(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.LoadESigDetails, (UserQueryMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserQueryMaint) null, (UserQueryMaint_LoadESigDetails_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserQueryMaint userQueryMaint)
    {
      return this.LoadESigDetails(userQueryMaint, (UserQueryMaint_LoadESigDetails_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.LoadESigDetails(userQueryMaint, (UserQueryMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).New(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus New(UserQueryMaint userQueryMaint)
    {
      return this.New(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus New(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.New(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).NewCopy(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus NewCopy(UserQueryMaint userQueryMaint)
    {
      return this.NewCopy(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.NewCopy(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).SaveAs(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus SaveAs(UserQueryMaint userQueryMaint)
    {
      return this.SaveAs(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.SaveAs(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userQueryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).UnFreeze(this._UserProfile, userQueryMaint, parameters, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(userQueryMaint, UserQueryMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userQueryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserQueryMaint) null, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus UnFreeze(UserQueryMaint userQueryMaint)
    {
      return this.UnFreeze(userQueryMaint, (UserQueryMaint_Parameters) null, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.UnFreeze(userQueryMaint, (UserQueryMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserQueryMaint) userQueryMaint, (UserQueryMaint_LoadESigDetails_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.New((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userQueryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserQueryMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserQueryMaint) userQueryMaint, (UserQueryMaint_Parameters) parameters, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      try
      {
        UserQueryMaintMethod[] methods = new UserQueryMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserQueryMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserQueryMaint cdo,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      try
      {
        return ((IUserQueryMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserQueryMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserQueryMaint) cdo, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.GetEnvironment((UserQueryMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserQueryMaint cdo,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      result = (UserQueryMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserQueryMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserQueryMaintMethod(cdo, UserQueryMaintMethods.ExecuteTransaction, (UserQueryMaint_Parameters) null));
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
        UserQueryMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserQueryMaint) cdo, (UserQueryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserQueryMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserQueryMaint_Request) null, out UserQueryMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result)
    {
      return this.ExecuteTransaction((UserQueryMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserQueryMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserQueryMaintMethod(cdo, UserQueryMaintMethods.AddDataTransaction, (UserQueryMaint_Parameters) null));
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
        return this.AddDataTransaction((UserQueryMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
