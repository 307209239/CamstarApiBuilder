// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserProfileMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UserProfileMaintService : SubentityMaintenanceBase
  {
    public UserProfileMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUserProfileMaintService), userProfile);
    }

    public ResultStatus Delete(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).Delete(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Delete(UserProfileMaint userProfileMaint)
    {
      return this.Delete(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Delete(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.Delete(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).Freeze(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Freeze(UserProfileMaint userProfileMaint)
    {
      return this.Freeze(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Freeze(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.Freeze(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).GetWIPMsgs(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UserProfileMaint userProfileMaint)
    {
      return this.GetWIPMsgs(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.GetWIPMsgs(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).Load(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Load(UserProfileMaint userProfileMaint)
    {
      return this.Load(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus Load(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.Load(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_LoadESigDetails_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).LoadESigDetails(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.LoadESigDetails, (UserProfileMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UserProfileMaint) null, (UserProfileMaint_LoadESigDetails_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UserProfileMaint userProfileMaint)
    {
      return this.LoadESigDetails(userProfileMaint, (UserProfileMaint_LoadESigDetails_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.LoadESigDetails(userProfileMaint, (UserProfileMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).New(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus New(UserProfileMaint userProfileMaint)
    {
      return this.New(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus New(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.New(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).NewCopy(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus NewCopy(UserProfileMaint userProfileMaint)
    {
      return this.NewCopy(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus NewCopy(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.NewCopy(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).SaveAs(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus SaveAs(UserProfileMaint userProfileMaint)
    {
      return this.SaveAs(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus SaveAs(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.SaveAs(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Parameters parameters,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) userProfileMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).UnFreeze(this._UserProfile, userProfileMaint, parameters, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(userProfileMaint, UserProfileMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) userProfileMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UserProfileMaint) null, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus UnFreeze(UserProfileMaint userProfileMaint)
    {
      return this.UnFreeze(userProfileMaint, (UserProfileMaint_Parameters) null, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UserProfileMaint userProfileMaint,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.UnFreeze(userProfileMaint, (UserProfileMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UserProfileMaint) userProfileMaint, (UserProfileMaint_LoadESigDetails_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.New((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.Load((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject userProfileMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UserProfileMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UserProfileMaint) userProfileMaint, (UserProfileMaint_Parameters) parameters, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      try
      {
        UserProfileMaintMethod[] methods = new UserProfileMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUserProfileMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserProfileMaint cdo,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      try
      {
        return ((IUserProfileMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UserProfileMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UserProfileMaint) cdo, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.GetEnvironment((UserProfileMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UserProfileMaint cdo,
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      result = (UserProfileMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUserProfileMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UserProfileMaintMethod(cdo, UserProfileMaintMethods.ExecuteTransaction, (UserProfileMaint_Parameters) null));
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
        UserProfileMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UserProfileMaint) cdo, (UserProfileMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UserProfileMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UserProfileMaint_Request) null, out UserProfileMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UserProfileMaint_Request request,
      out UserProfileMaint_Result result)
    {
      return this.ExecuteTransaction((UserProfileMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UserProfileMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UserProfileMaintMethod(cdo, UserProfileMaintMethods.AddDataTransaction, (UserProfileMaint_Parameters) null));
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
        return this.AddDataTransaction((UserProfileMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
