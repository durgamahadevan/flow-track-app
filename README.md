# flow-track-app
A domain-driven, multi-tenant work management platform built from scratch to explore real-world backend and frontend architecture.


# Vision
FlowTrack aims to be a flexible, multi-tenant work and operations management platform that supports both individual users and licensed organizations, with a strong focus on auditability, security, and extensibility.


## Learning Goals
This project is intentionally designed to:
- Explore end-to-end system design and implementation
- Build confidence in architectural and performance-related decisions
- Practice risk-taking through experimentation and refactoring
- Simulate real-world constraints not always encountered in day-to-day work


## Problem Statement
FlowTrack is a hybrid work management platform offering limited public functionality for individual users and advanced, license-based capabilities for organizations.

The system is designed with:
- Explicit tenant isolation
- License-aware authorization
- Customizable workflows
- Strong auditability

The platform prioritizes clear domain boundaries and predictable APIs, enabling future evolution without forcing early architectural complexity.



## Non-Goals
- Building a microservices architecture in the initial versions
- Supporting mobile clients
- Implementing external identity providers (SSO, OAuth)
- Optimizing for extreme scale or high availability early
- Providing real-time collaboration features



## High-Level Architecture

FlowTrack follows a layered architecture with clear separation of concerns:

- Domain layer contains core business entities and rules
- Application layer orchestrates use cases and authorization decisions
- Infrastructure layer handles persistence, authentication, and external concerns
- API layer exposes HTTP endpoints and request handling

Key architectural principles:
- Tenant isolation enforced at the data and application layers
- Authorization decisions depend on user roles and tenant license capabilities
- Business rules live outside controllers and infrastructure code



## Core Capabilities (Planned)

- User, tenant, role, and policy management governed by license
- Projects containing hierarchical tasks
- Multiple task types (Feature, Bug, Story, Spike)
- Fixed and customizable task fields
- Custom workflows with configurable states
- Rich task content (text, images, code blocks)
- Permission-based access:
  - Bulk edits
  - Cross-project views
  - Read-only audit access
  - Basic querying




