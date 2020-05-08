FROM centos:7

#-------DotNet Core------------
RUN rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
RUN yum install -y dotnet-sdk-3.1

#-------Workdir--------------
ADD . /project
WORKDIR /project